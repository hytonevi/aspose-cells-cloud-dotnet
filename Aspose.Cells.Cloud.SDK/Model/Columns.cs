// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Columns.cs">
//   Copyright (c) 2016 Aspose.Cells for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Cells.Cloud.SDK.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// 
  /// </summary>  
  [DataContract]
  public class Columns 
  {                       
        /// <summary>
        /// Gets or sets Link
        /// </summary>  
		[DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Gets or sets ColumnsCount
        /// </summary>  
		[DataMember(Name="ColumnsCount", EmitDefaultValue=false)]
        public int? ColumnsCount { get; set; }

        /// <summary>
        /// Gets or sets MaxColumn
        /// </summary>  
		[DataMember(Name="MaxColumn", EmitDefaultValue=false)]
        public int? MaxColumn { get; set; }

        /// <summary>
        /// Gets or sets ColumnsList
        /// </summary>  
		[DataMember(Name="ColumnsList", EmitDefaultValue=false)]
        public List<LinkElement> ColumnsList { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Columns {\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("  ColumnsCount: ").Append(this.ColumnsCount).Append("\n");
          sb.Append("  MaxColumn: ").Append(this.MaxColumn).Append("\n");
          sb.Append("  ColumnsList: ").Append(this.ColumnsList).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
