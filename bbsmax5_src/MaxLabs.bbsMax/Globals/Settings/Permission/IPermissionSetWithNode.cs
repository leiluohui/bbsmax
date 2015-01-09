﻿//
// 请注意：bbsmax 不是一个免费产品，源代码仅限用于学习，禁止用于商业站点或者其他商业用途
// 如果您要将bbsmax用于商业用途，需要从官方购买商业授权，得到授权后可以基于源代码二次开发
//
// 版权所有 厦门麦斯网络科技有限公司
// 公司网站 www.bbsmax.com
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using MaxLabs.bbsMax.Entities;

namespace MaxLabs.bbsMax.Settings
{
    /// <summary>
    /// 需要在Initializer中 注册
    /// </summary>
    public interface IPermissionSetWithNode
    {
        string TypeName { get; }

        string Name { get; }

        IPermissionSet GetNode(int nodeID);

        bool SaveSetting(IPermissionSet setting);

        bool DeleteSetting(int NodeID);
    }
}