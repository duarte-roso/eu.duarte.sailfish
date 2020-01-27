using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Unity.iOS.Device
{
    public class iOSDevice
    {
        #region Device model map
        
        private static Dictionary<string, Generation> s_modelMap = new Dictionary<string, Generation>() {
            { "", Generation.Unknown },
            // iPod Touch

            // iPad
            { "iPad1,1", Generation.iPad },
            { "iPad2,1", Generation.iPad2 },
            { "iPad2,2", Generation.iPad2 },
            { "iPad2,3", Generation.iPad2 },
            { "iPad2,4", Generation.iPad2 },
            { "iPad3,1", Generation.iPadGen3 },
            { "iPad3,2", Generation.iPadGen3 },
            { "iPad3,3", Generation.iPadGen3 },
            { "iPad3,4", Generation.iPadGen4 },
            { "iPad3,5", Generation.iPadGen4 },
            { "iPad3,6", Generation.iPadGen4 },
            { "iPad6,11", },
            { "iPad6,12", },
            { "iPad7,5", },
            { "iPad7,6", },
            { "iPad7,11", },
            { "iPad7,12", },

            { "" , },
            { "" , },
            { "" , },
            { "" , },
            { "" , },
            { "" , },
            { "" , },
            { "" , },
            { "" , },
            { "" , },
            { "" , },
            { "" , },
            { "" , },
        };

        #endregion


        #region Properties

        public Generation DeviceGeneration {
            get {
                string modelID = SystemInfo.deviceModel;
                if (!s_modelMap.ContainsKey(modelID))
                    return Generation.Unknown;
                
                return s_modelMap[modelID];
            }
        }
        
        #endregion
    }
}