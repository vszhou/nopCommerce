﻿using FluentMigrator;
using Nop.Data.Migrations;
using Nop.Services.Localization;

namespace Nop.Web.Framework.Migrations.Nop440
{
    [NopMigration("2020/07/02 13:36:08:1037680")]
    public class Localization : AutoReversingMigration
    {
        private readonly ILocalizationService _localizationService;

        public Localization(ILocalizationService localizationService)
        {
            _localizationService = localizationService;
        }

        /// <summary>Collect the UP migration expressions</summary>
        public override void Up()
        {
            _localizationService.AddOrUpdateLocaleResource("Admin.System.Warnings.PluginsOverrideSameService", "The \"{0}\" service has been overridden in those plugins: {1}. This situation may cause errors because there is only one of them will be used");
        }
    }
}
