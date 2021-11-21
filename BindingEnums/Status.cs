// <copyright file="Status.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using BindingEnums.Resources;
using System.ComponentModel;

namespace BindingEnums
{
    /// <summary>
    /// Status.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Status
    {
        /// <summary>
        /// Horrible.
        /// </summary>
        [Description("This is horrible")]
        Horrible,

        /// <summary>
        /// Bad.
        /// </summary>
        [Description("This is bad")]
        Bad,

        /// <summary>
        /// SoSo.
        /// </summary>
        [Description("This is so so")]
        SoSo,

        /// <summary>
        /// Good.
        /// </summary>
        [LocalizedDescription("Good", typeof(EnumResources))]
        Good,

        /// <summary>
        /// Better.
        /// </summary>
        [LocalizedDescription("Better", typeof(EnumResources))]
        Better,

        /// <summary>
        /// Best.
        /// </summary>
        [LocalizedDescription("Best", typeof(EnumResources))]
        Best,
    }
}
