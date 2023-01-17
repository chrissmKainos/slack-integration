using Slack_Integration.Slack;
using System.Xml.Linq;

SlackConfig slackConfig = new SlackConfig
    {WebhookUrl = ""};
ISlackClient slackClient = new SlackClient(slackConfig);

SlackMessageBuilder slackMessageBuilder = new SlackMessageBuilder();
slackMessageBuilder.Add(":office_worker:* New user registered*");
slackMessageBuilder.Add(new List<string>{ "*Name *: Chris Smith", "*Username*: chsm19" }); 
slackMessageBuilder.Add(new List<string> { "*Job Title*: Senior Software Engineer", "*Website*: <https://example.com|Blog by Chris>" });
slackMessageBuilder.AddDivider();
slackMessageBuilder.Add("Please welcome Chris to the team :wave:");
slackClient.PostMessage(slackMessageBuilder.BuildSlackMessage());