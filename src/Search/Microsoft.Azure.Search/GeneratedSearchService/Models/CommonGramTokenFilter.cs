// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using Azure;
    using Search;
    using Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Construct bigrams for frequently occurring terms while indexing. Single
    /// terms are still indexed too, with bigrams overlaid. This token filter
    /// is implemented using Apache Lucene.
    /// <see href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/commongrams/CommonGramsFilter.html" />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Azure.Search.CommonGramTokenFilter")]
    public partial class CommonGramTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the CommonGramTokenFilter class.
        /// </summary>
        public CommonGramTokenFilter() { }

        /// <summary>
        /// Initializes a new instance of the CommonGramTokenFilter class.
        /// </summary>
        /// <param name="commonWords">The set of common words.</param>
        /// <param name="ignoreCase">A value indicating whether common words
        /// matching will be case insensitive. Default is false.</param>
        /// <param name="useQueryMode">A value that indicates whether the token
        /// filter is in query mode. When in query mode, the token filter
        /// generates bigrams and then removes common words and single terms
        /// followed by a common word. Default is false.</param>
        public CommonGramTokenFilter(string name, IList<string> commonWords, bool? ignoreCase = default(bool?), bool? useQueryMode = default(bool?))
            : base(name)
        {
            CommonWords = commonWords;
            IgnoreCase = ignoreCase;
            UseQueryMode = useQueryMode;
        }

        /// <summary>
        /// Gets or sets the set of common words.
        /// </summary>
        [JsonProperty(PropertyName = "commonWords")]
        public IList<string> CommonWords { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether common words matching will
        /// be case insensitive. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "ignoreCase")]
        public bool? IgnoreCase { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether the token filter is in
        /// query mode. When in query mode, the token filter generates bigrams
        /// and then removes common words and single terms followed by a common
        /// word. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "queryMode")]
        public bool? UseQueryMode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (CommonWords == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CommonWords");
            }
        }
    }
}

