using Alexa.NET;
using Alexa.NET.Request;
using Amazon.Lambda.Core;
using Amazon.S3;
using Newtonsoft.Json;
using SpiritualAdviceAlexaSkill.Infrastructure.Arcana;
using SpiritualAdviceAlexaSkill.Infrastructure.Builders;
using SpiritualAdviceAlexaSkill.Infrastructure.Provider;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace SpiritualAdviceAlexaSkill;

public class Function
{

    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public string FunctionHandler(SkillRequest input, ILambdaContext context)
    {
        IDateProvider _dateProvider = new DateProvider();
        IArcanaCalculator _arcanaCalculator = new ArcanaCalculator(_dateProvider);

        var todaysArcana = _arcanaCalculator.TodaysArcanum();
        var preSignedUrl = getPreSignedUrl(todaysArcana.Speech);

        var ssmlBuilder = new SsmlBuilder();
        ssmlBuilder.AddAudio(preSignedUrl);

        return JsonConvert.SerializeObject(ResponseBuilder.Tell(ssmlBuilder.BuildSpeech()));
    }

    private string getPreSignedUrl(string fileName)
    {
        // Create an S3 client object.
        var s3Client = new AmazonS3Client();

        var preSignedUrl = s3Client.GetPreSignedURL(new Amazon.S3.Model.GetPreSignedUrlRequest()
        {
            BucketName = "audio-bkt",
            Key = fileName,
            Expires = DateTime.UtcNow.AddHours(1)
        });

        return preSignedUrl;
    }
}
