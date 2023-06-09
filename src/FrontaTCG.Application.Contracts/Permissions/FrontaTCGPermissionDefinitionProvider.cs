﻿using FrontaTCG.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FrontaTCG.Permissions;

public class FrontaTCGPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FrontaTCGPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(FrontaTCGPermissions.MyPermission1, L("Permission:MyPermission1"));
        myGroup.AddPermission("EditCards", L("EditCards"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FrontaTCGResource>(name);
    }
}
