﻿using Nacollector.Browser;
using NacollectorSpiders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nacollector.JsActions
{
    /// <summary>
    /// 任务控制器操作
    /// </summary>
    [Serializable]
    class TaskControllerAction
    {
        private MainForm _form;
        private CrBrowser crBrowser;

        public TaskControllerAction(MainForm form, CrBrowser crBrowser)
        {
            this._form = form;
            this.crBrowser = crBrowser;
        }
        
        // 创建新任务
        public void createTask(string taskId, string className, string classLabel, string parmsJsonStr)
        {
            // 配置
            var settings = new Dictionary<string, object>
            {
                { "TaskId", taskId },
                { "ClassName", className },
                { "ClassLabel", classLabel },
                { "ParmsJsonStr", parmsJsonStr }
            };

            _form.NewTaskThread(settings);
        }

        // 终止任务
        public bool abortTask(string taskId)
        {
            return _form.AbortTask(taskId);
        }
    }
}
