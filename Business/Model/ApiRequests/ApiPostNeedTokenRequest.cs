﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WX.Model.ApiResponses;

namespace WX.Model.ApiRequests
{
    public abstract class ApiPostNeedTokenRequest<T> : ApiRequest<T>
        where T : ApiResponse
    {
        internal override string Method
        {
            get { return POSTMETHOD; }
        }

        protected abstract override string UrlFormat { get; }

        internal override string GetUrl()
        {
            return String.Format(UrlFormat, AccessToken);
        }

        protected override bool NeedToken
        {
            get { return true; }
        }

        public override string GetPostContent()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
