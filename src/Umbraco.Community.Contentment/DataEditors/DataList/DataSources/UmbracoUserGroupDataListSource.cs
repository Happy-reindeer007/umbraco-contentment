﻿/* Copyright © 2021 Lee Kelleher.
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.Linq;
#if NET472
using Umbraco.Core.Models.Membership;
using Umbraco.Core.PropertyEditors;
using Umbraco.Core.Services;
using UmbConstants = Umbraco.Core.Constants;
#else
using Umbraco.Cms.Core.Models.Membership;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Services;
using UmbConstants = Umbraco.Cms.Core.Constants;
#endif

namespace Umbraco.Community.Contentment.DataEditors
{
    public sealed class UmbracoUserGroupDataListSource : IDataListSource, IDataListSourceValueConverter
    {
        private readonly IUserService _userService;

        public UmbracoUserGroupDataListSource(IUserService userService)
        {
            _userService = userService;
        }

        public string Name => "Umbraco User Groups";

        public string Description => "Populate the data source with Umbraco user groups.";

        public string Icon => UmbConstants.Icons.UserGroup;

        public string Group => Constants.Conventions.DataSourceGroups.Umbraco;

        public IEnumerable<ConfigurationField> Fields => default;

        public Dictionary<string, object> DefaultValues => default;

        public OverlaySize OverlaySize => OverlaySize.Small;

        public IEnumerable<DataListItem> GetItems(Dictionary<string, object> config)
        {
            return _userService
                .GetAllUserGroups()
                .Select(x => new DataListItem
                {
                    Name = x.Name,
                    Value = x.Alias,
                    Icon = x.Icon ?? UmbConstants.Icons.UserGroup,
                    Description = string.Join(", ", x.AllowedSections)
                });
        }

        public Type GetValueType(Dictionary<string, object> config) => typeof(IUserGroup);

        public object ConvertValue(Type type, string value) => _userService.GetUserGroupByAlias(value);
    }
}
