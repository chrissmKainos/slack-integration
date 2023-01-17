using Slack.Webhooks;

namespace Slack_Integration.Slack;

public interface ISlackClient
{
    void PostMessage(SlackMessage slackMessage);
}
