// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Insights.Models;

namespace Microsoft.Azure.Management.Insights.Models
{
    /// <summary>
    /// The parameters for the scaling action.
    /// </summary>
    public partial class ScaleAction
    {
        private TimeSpan _cooldown;
        
        /// <summary>
        /// Optional. Gets or sets the amount of time to wait since the last
        /// scaling action before this action occurs. Must be between 1 week
        /// and 1 minute.
        /// </summary>
        public TimeSpan Cooldown
        {
            get { return this._cooldown; }
            set { this._cooldown = value; }
        }
        
        private ScaleDirection _direction;
        
        /// <summary>
        /// Optional. Gets or sets the scale direction. Whether the scaling
        /// action increases or decreases the number of instances.
        /// </summary>
        public ScaleDirection Direction
        {
            get { return this._direction; }
            set { this._direction = value; }
        }
        
        private ScaleType _type;
        
        /// <summary>
        /// Optional. Gets or sets the type of action that should occur, this
        /// must be set to ChangeCount.
        /// </summary>
        public ScaleType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        private string _value;
        
        /// <summary>
        /// Optional. Gets or sets the number of instances that are involved in
        /// the scaling action. This value must be 1 or greater. The default
        /// value is 1.
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ScaleAction class.
        /// </summary>
        public ScaleAction()
        {
        }
    }
}
