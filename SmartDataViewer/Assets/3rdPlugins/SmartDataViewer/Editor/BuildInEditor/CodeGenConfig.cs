﻿//
//   		Copyright 2017 KeyleXiao.
//     		Contact : Keyle_xiao@hotmail.com 
//
//     		Licensed under the Apache License, Version 2.0 (the "License");
//     		you may not use this file except in compliance with the License.
//     		You may obtain a copy of the License at
//
//     		http://www.apache.org/licenses/LICENSE-2.0
//
//     		Unless required by applicable law or agreed to in writing, software
//     		distributed under the License is distributed on an "AS IS" BASIS,
//     		WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//     		See the License for the specific language governing permissions and
//     		limitations under the License.
//

using System;
using UnityEngine;

namespace SmartDataViewer.Editor.BuildInEditor
{
    [Serializable]
    [ConfigEditor(10001)]
    public class CodeGenConfig : ConfigBase<CodeGen>
    {
        public override CodeGen SearchByID(int id)
        {
            if (id == -1)
            {
                return new CodeGen{ID = -1,InOutPath = EditorConfig.CodeGenFilePath,ClassType = "SmartDataViewer.Editor.BuildInEditor.CodeGenConfig",SubType = "CodeGen"};
            }
            
            return base.SearchByID(id);
        }
    }

    [Serializable]
    public class CodeGen : IModel
    {
        public CodeGen()
        {
            EditorName = string.Empty;
            ClassType = string.Empty;
            SubType = string.Empty;
            EditorPath = "CustomEditor";
            InOutPath = string.Empty;
            CodeExportPath ="{ROOT}/Editor/Export/";
            ContainerType = DataContainerType.UNITY_JSON;
        }

        [ConfigEditorField(11015)]
        public DataContainerType ContainerType;
        [ConfigEditorField(11006)]
        public string InOutPath;
        [ConfigEditorField(11010)]
        public string EditorPath;
        [ConfigEditorField(11011)]
        public string EditorName;
        [ConfigEditorField(11012)]
        public string ClassType;
        [ConfigEditorField(11013)]
        public string SubType;
        [ConfigEditorField(11016)]
        public string CodeExportPath;
    }
}