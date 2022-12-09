using Alexa.NET.Response.Ssml;

namespace SpiritualAdviceAlexaSkill.Infrastructure.Builders;

public class SsmlBuilder
{
    private readonly List<ISsml> _elements = new();
    public Speech BuildSpeech() =>  new(_elements.ToArray());
    private SsmlBuilder AddToList(ISsml element)
    {
        _elements.Add(element);
        return this;
    }

    private SsmlBuilder AddToList(List<ISsml> elements)
    {
        _elements.AddRange(elements);
        return this;
    }

    public SsmlBuilder AddAudio(string source, Func<List<ISsml>>? _elements = null)
    {
        var audio = new Audio(source)
        {
            Elements = _elements?.Invoke() ?? new List<ISsml>()
        };

        return AddToList(audio);
    }
}
