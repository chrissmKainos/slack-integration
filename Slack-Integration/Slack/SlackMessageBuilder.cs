using Slack.Webhooks;
using Slack.Webhooks.Blocks;
using Slack.Webhooks.Elements;
using static System.Net.Mime.MediaTypeNames;

namespace Slack_Integration.Slack;

internal sealed class SlackMessageBuilder
{
    private readonly IList<Block> _blocks = new List<Block>();

    public SlackMessageBuilder Add(string text)
    {
        var section = new Section
        {
            Text = new TextObject
            {
                Text = text,
                Type = TextObject.TextType.Markdown

            }
        };
        _blocks.Add(section);
        return this;
    }

    public SlackMessageBuilder Add(List<string> fields)
    {
        var section = new Section
        {
            Fields = new List<TextObject>()
        };

        foreach (var field in fields)
        {
            section.Fields.Add(new TextObject
            {
                Text = field,
                Type = TextObject.TextType.Markdown

            });
        }

        _blocks.Add(section);
        return this;
    }

    public SlackMessageBuilder AddDivider()
    {
        _blocks.Add(new Divider());
        return this;
    }

    public SlackMessage BuildSlackMessage()
    {
        return new SlackMessage
        {
            Blocks = _blocks.ToList()
        };
    }
}