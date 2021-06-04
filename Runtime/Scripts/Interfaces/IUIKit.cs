using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinaX.Systems.Pipeline;
using TinaX.UIKit.Entity;
using TinaX.UIKit.Pipelines.OpenUI;
using TinaX.UIKit.Router;
using TinaX.XComponent;
using UnityEngine;

namespace TinaX.UIKit
{
    public interface IUIKit
    {
        Camera UICamera { get; }
        XPipeline<IOpenUIAsyncHandler> OpenUIAsyncPipeline { get; }
        XPipeline<IOpenUIHandler> OpenUIPipeline { get; }

        void CloseUI(UIEntity entity, params object[] args);
        void CloseUI(string UIName, params object[] args);

        // ------ UIName / Args 
        IUIEntity OpenUI(string UIName, params object[] args);
        Task<IUIEntity> OpenUIAsync(string UIName, params object[] args);
        void OpenUIAsync(string UIName, Action<IUIEntity, XException> callback, params object[] args);


        // ------ UIName / Behavioyr / Args
        IUIEntity OpenUI(string UIName, XBehaviour behaviour, params object[] args);
        Task<IUIEntity> OpenUIAsync(string UIName, XBehaviour behaviour, params object[] args);
        void OpenUIAsync(string UIName, XBehaviour behaviour, Action<IUIEntity, XException> callback, params object[] args);


        // ------ UIName, Params / Args
        IUIEntity OpenUI(string UIName, OpenUIParam openUIParam, params object[] args);
        Task<IUIEntity> OpenUIAsync(string UIName, OpenUIParam openUIParam, params object[] args);
        void OpenUIAsync(string UIName, OpenUIParam openUIParam, Action<IUIEntity, XException> callback, params object[] args);
        

        
        // ------ UIName / Behaviour / Params /Args
        IUIEntity OpenUI(string UIName, XBehaviour behaviour, OpenUIParam openUIParam, params object[] args);
        Task<IUIEntity> OpenUIAsync(string UIName, XBehaviour behaviour, OpenUIParam openUIParam, params object[] args);
        void OpenUIAsync(string UIName, XBehaviour behaviour, OpenUIParam openUIParam, Action<IUIEntity, XException> callback, params object[] args);
        
        
        IUIEntity OpenUIWithParam(string UIName, OpenUIParam openUIParam, params object[] args);
        void OpenUIWithParamAsync(string UIName, OpenUIParam openUIParam, Action<IUIEntity, XException> callback, params object[] args);
        void SetUIRouter(IRouter router);
    }
}
