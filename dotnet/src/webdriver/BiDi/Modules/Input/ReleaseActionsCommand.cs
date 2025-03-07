using OpenQA.Selenium.BiDi.Communication;

#nullable enable

namespace OpenQA.Selenium.BiDi.Modules.Input;

internal class ReleaseActionsCommand(ReleaseActionsCommandParameters @params) : Command<ReleaseActionsCommandParameters>(@params);

internal record ReleaseActionsCommandParameters(BrowsingContext.BrowsingContext Context) : CommandParameters;

public record ReleaseActionsOptions : CommandOptions;
