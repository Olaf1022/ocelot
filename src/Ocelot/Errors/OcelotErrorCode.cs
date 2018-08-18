﻿namespace Ocelot.Errors
{
    public enum OcelotErrorCode
    {
        UnauthenticatedError, 
        UnknownError,
        DownstreampathTemplateAlreadyUsedError,
        UnableToFindDownstreamRouteError,
        CannotAddDataError,
        CannotFindDataError,
        UnableToCompleteRequestError,
        UnableToCreateAuthenticationHandlerError,
        UnsupportedAuthenticationProviderError,
        CannotFindClaimError,
        ParsingConfigurationHeaderError,
        NoInstructionsError,
        InstructionNotForClaimsError,
        UnauthorizedError,
        ClaimValueNotAuthorisedError,
        ScopeNotAuthorisedError,
        UserDoesNotHaveClaimError,
        DownstreamPathTemplateContainsSchemeError,
        DownstreamPathNullOrEmptyError,
        DownstreamSchemeNullOrEmptyError,
        DownstreamHostNullOrEmptyError,
        ServicesAreNullError,
        ServicesAreEmptyError,
        UnableToFindServiceDiscoveryProviderError,
        UnableToFindLoadBalancerError,
        RequestTimedOutError,
        UnableToFindQoSProviderError,
        UnmappableRequestError,
        RateLimitOptionsError,
        PathTemplateDoesntStartWithForwardSlash,
        FileValidationFailedError,
        UnableToFindDelegatingHandlerProviderError,
        CouldNotFindPlaceholderError,
        CouldNotFindAggregatorError
    }
}
