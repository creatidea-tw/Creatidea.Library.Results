﻿namespace Ci.Result
{
    /// <summary>
    /// Result code
    /// </summary>
    public enum Result
    {
        /// <summary>
        /// Everything went well
        /// </summary>
        Success = 1,

        /// <summary>
        /// Something went wrong
        /// </summary>
        Failure = 2,

        /// <summary>
        /// Can not find something
        /// </summary>
        NotFound = 3,

        /// <summary>
        /// Took too long to process something
        /// </summary>
        Timeout = 4,

        /// <summary>
        /// Same thing already exist
        /// </summary>
        Duplicate = 5,

        InValid = 6,
        Expired = 7,
        HasUsed = 8,
        UnAuthorized = 9,

        /// <summary>
        /// database query error
        /// </summary>
        DbError = 10,

        /// <summary>
        /// parameter error
        /// </summary>
        ParameterError = 11
    }
}
