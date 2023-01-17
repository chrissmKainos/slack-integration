using SW = Slack.Webhooks;

namespace Slack_Integration.Slack;

public class SlackClient : ISlackClient
{
    private readonly SW.SlackClient _slackClient;

    public SlackClient(SlackConfig slackConfig)
    {
        _slackClient =
            new SW.SlackClient(slackConfig.WebhookUrl);
    }

    public void PostMessage(SW.SlackMessage slackMessage)
    {
        _slackClient.Post(slackMessage);
    }
}