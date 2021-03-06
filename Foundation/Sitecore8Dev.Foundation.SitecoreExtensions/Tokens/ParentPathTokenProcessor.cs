﻿using Sitecore.Pipelines.ExpandInitialFieldValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore8Dev.Foundation.SitecoreExtensions.Tokens
{
    public class ParentPathTokenProcessor : ExpandInitialFieldValueProcessor
    {
        public override void Process(ExpandInitialFieldValueArgs args)
        {
            var token = args.SourceField.Value;
            if (!String.IsNullOrEmpty(token) && token.Contains("$parentPath"))
            {
                if (args.TargetItem != null)
                {
                    args.Result = args.Result.Replace("$parentPath", args.TargetItem.Paths.ParentPath);
                }
            }
        }
    }
}