﻿//
// 请注意：bbsmax 不是一个免费产品，源代码仅限用于学习，禁止用于商业站点或者其他商业用途
// 如果您要将bbsmax用于商业用途，需要从官方购买商业授权，得到授权后可以基于源代码二次开发
//
// 版权所有 厦门麦斯网络科技有限公司
// 公司网站 www.bbsmax.com
//

using System;

using MaxLabs.WebEngine;
using MaxLabs.bbsMax.Rescourses;

namespace MaxLabs.bbsMax.Errors
{
    public class PostRateOverMinValueError : ErrorInfo
    {
        public PostRateOverMinValueError(string pointName, int pointValue, int minValue)
        {
            PointName = pointName;
            PointValue = pointValue;
            MinValue = minValue;
        }

        public string PointName { private set; get; }
        public int PointValue { private set; get; }
        public int MinValue { private set; get; }

        public override string Message
        {
            get { return string.Format(Lang_Error.Topic_PostRateOverMinValue, PointName, PointValue, MinValue); }
        }
    }
}