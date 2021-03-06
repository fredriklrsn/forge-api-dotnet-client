/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: forge.help@autodesk.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Autodesk.Forge.Model
{
    /// <summary>
    /// Advanced options for &#x60;obj&#x60; type.
    /// </summary>
    [DataContract]
    public partial class JobObjOutputPayloadAdvanced :  IEquatable<JobObjOutputPayloadAdvanced>
    {
        /// <summary>
        /// `single` (default): creates one OBJ file for all the input files (assembly file)  `multiple`: creates a separate OBJ file for each object 
        /// </summary>
        /// <value>`single` (default): creates one OBJ file for all the input files (assembly file)  `multiple`: creates a separate OBJ file for each object </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExportFileStructureEnum
        {
            
            /// <summary>
            /// Enum Single for "single"
            /// </summary>
            [EnumMember(Value = "single")]
            Single,
            
            /// <summary>
            /// Enum Multiple for "multiple"
            /// </summary>
            [EnumMember(Value = "multiple")]
            Multiple
        }

        /// <summary>
        /// `single` (default): creates one OBJ file for all the input files (assembly file)  `multiple`: creates a separate OBJ file for each object 
        /// </summary>
        /// <value>`single` (default): creates one OBJ file for all the input files (assembly file)  `multiple`: creates a separate OBJ file for each object </value>
        [DataMember(Name="exportFileStructure", EmitDefaultValue=false)]
        public ExportFileStructureEnum? ExportFileStructure { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobObjOutputPayloadAdvanced" /> class.
        /// </summary>
        /// <param name="ExportFileStructure">&#x60;single&#x60; (default): creates one OBJ file for all the input files (assembly file)  &#x60;multiple&#x60;: creates a separate OBJ file for each object  (default to &quot;single&quot;).</param>
        /// <param name="ModelGuid">Required for geometry extractions. The model view ID (guid)..</param>
        /// <param name="ObjectIds">Required for geometry extractions. List object ids to be translated. -1 will extract the entire model. .</param>
        public JobObjOutputPayloadAdvanced(ExportFileStructureEnum? ExportFileStructure = null, string ModelGuid = null, List<int> ObjectIds = null)
        {
            // use default value if no "ExportFileStructure" provided
            if (ExportFileStructure == null)
            {
                this.ExportFileStructure = (ExportFileStructureEnum)Enum.Parse(typeof(ExportFileStructureEnum), "single", true);
            }
            else
            {
                this.ExportFileStructure = ExportFileStructure;
            }
            this.ModelGuid = ModelGuid;
            this.ObjectIds = ObjectIds;
        }
        
        /// <summary>
        /// Required for geometry extractions. The model view ID (guid).
        /// </summary>
        /// <value>Required for geometry extractions. The model view ID (guid).</value>
        [DataMember(Name="modelGuid", EmitDefaultValue=false)]
        public string ModelGuid { get; set; }
        /// <summary>
        /// Required for geometry extractions. List object ids to be translated. -1 will extract the entire model. 
        /// </summary>
        /// <value>Required for geometry extractions. List object ids to be translated. -1 will extract the entire model. </value>
        [DataMember(Name="objectIds", EmitDefaultValue=false)]
        public List<int> ObjectIds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobObjOutputPayloadAdvanced {\n");
            sb.Append("  ExportFileStructure: ").Append(ExportFileStructure).Append("\n");
            sb.Append("  ModelGuid: ").Append(ModelGuid).Append("\n");
            sb.Append("  ObjectIds: ").Append(ObjectIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as JobObjOutputPayloadAdvanced);
        }

        /// <summary>
        /// Returns true if JobObjOutputPayloadAdvanced instances are equal
        /// </summary>
        /// <param name="other">Instance of JobObjOutputPayloadAdvanced to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobObjOutputPayloadAdvanced other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ExportFileStructure == other.ExportFileStructure ||
                    this.ExportFileStructure != null &&
                    this.ExportFileStructure.Equals(other.ExportFileStructure)
                ) && 
                (
                    this.ModelGuid == other.ModelGuid ||
                    this.ModelGuid != null &&
                    this.ModelGuid.Equals(other.ModelGuid)
                ) && 
                (
                    this.ObjectIds == other.ObjectIds ||
                    this.ObjectIds != null &&
                    this.ObjectIds.SequenceEqual(other.ObjectIds)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ExportFileStructure != null)
                    hash = hash * 59 + this.ExportFileStructure.GetHashCode();
                if (this.ModelGuid != null)
                    hash = hash * 59 + this.ModelGuid.GetHashCode();
                if (this.ObjectIds != null)
                    hash = hash * 59 + this.ObjectIds.GetHashCode();
                return hash;
            }
        }
    }

}

