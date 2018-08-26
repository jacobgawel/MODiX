﻿using System;

using Modix.Data.Models.Core;

namespace Modix.Data.Models.Core
{
    /// <summary>
    /// Describes an operation to create a <see cref="DesignatedChannelMappingEntity"/>.
    /// </summary>
    public class DesignatedChannelMappingCreationData
    {
        /// <summary>
        /// See <see cref="DesignatedChannelMappingEntity.GuildId"/>.
        /// </summary>
        public ulong GuildId { get; set; }

        /// <summary>
        /// See <see cref="DesignatedChannelMappingEntity.ChannelId"/>.
        /// </summary>
        public ulong ChannelId { get; set; }

        /// <summary>
        /// See <see cref="DesignatedChannelMappingEntity.ChannelDesignation"/>
        /// </summary>
        public ChannelDesignation ChannelDesignation { get; set; }

        /// <summary>
        /// See <see cref="ConfigurationActionEntity.CreatedById"/>.
        /// </summary>
        public ulong CreatedById { get; set; }

        internal DesignatedChannelMappingEntity ToEntity()
            => new DesignatedChannelMappingEntity()
            {
                GuildId = (long)GuildId,
                ChannelId = (long)ChannelId,
                ChannelDesignation = ChannelDesignation,
                CreateAction = new ConfigurationActionEntity()
                {
                    GuildId = (long)GuildId,
                    Type = ConfigurationActionType.DesignatedChannelMappingCreated,
                    Created = DateTimeOffset.Now,
                    CreatedById = (long)CreatedById
                }
            };
    }
}
