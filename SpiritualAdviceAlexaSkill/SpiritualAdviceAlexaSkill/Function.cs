using Alexa.NET;
using Alexa.NET.Request;
using Alexa.NET.Response.Ssml;
using Amazon.Lambda.Core;
using Newtonsoft.Json;
using SpiritualAdviceAlexaSkill.Infrastructure.Arcana;
using SpiritualAdviceAlexaSkill.Infrastructure.Provider;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.LambdaJsonSerializer))]

namespace SpiritualAdviceAlexaSkill;

public class Function
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public string FunctionHandler(SkillRequest input, ILambdaContext context)
    {
        IDateProvider _dateProvider = new DateProvider();
        IArcanaCalculator _arcanaCalculator = new ArcanaCalculator(_dateProvider);

        var todaysArcana = _arcanaCalculator.TodaysArcanum();

        var speech = new Speech();
        var paragraph = new Paragraph();
        paragraph.Elements.Add(new PlainText(todaysArcana.Speech));

        var domain = new AmazonDomain("long-form");
        domain.Elements.Add(paragraph);        

        speech.Elements.Add(domain);

        return JsonConvert.SerializeObject(ResponseBuilder.Tell(speech));
    }
}
