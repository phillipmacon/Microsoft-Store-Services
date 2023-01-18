﻿//-----------------------------------------------------------------------------
// ClawbackV2OrderInfo.cs
//
// Xbox Advanced Technology Group (ATG)
// Copyright (C) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License file under the project root for
// license information.
//-----------------------------------------------------------------------------

using Newtonsoft.Json;
using System;

namespace Microsoft.StoreServices.Clawback.V2
{
    /// <summary>
    /// Represents a single product that was included in the purchase transaction made by the user.
    /// </summary>
    public class ClawbackV2OrderInfo
    {
        /// <summary>
        /// Unique Id representing this product within the purchase transaction.
        /// </summary>   
        [JsonProperty("lineItemId")]
        public string LineItemId { get; set; }

        /// <summary>
        /// OrderId represents a unique identifier for the purchase transaction this information is tied to.
        /// </summary>
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// ProductId (StoreId) of the item offered within the store.
        /// </summary>
        [JsonProperty("productId")]
        public string ProductId { get; set; }

        /// <summary>
        /// Product type the event relates to, Consumable or UnmanagedConsumable
        /// </summary>
        [JsonProperty("productType")]
        public string ProductType { get; set; }

        /// <summary>
        /// UTC date time when the purchase transaction was made.
        /// </summary>
        [JsonProperty("purchasedDate")]
        public DateTimeOffset PurchasedDate { get; set; }

        /// <summary>
        /// UTC date time when the purchase was refunded (if in a refunded state).
        /// </summary>
        [JsonProperty("refundInitiatedDate")]
        public DateTimeOffset RefundInitiatedDate { get; set; }

        /// <summary>
        /// Current state of the item indicating if it is active, revoked, or refunded.
        /// </summary>
        [JsonProperty("refundState")]
        public string RefundState { get; set; }

        /// <summary>
        /// UTC date time when the purchase transaction was made.
        /// </summary>
        [JsonProperty("sandboxId")]
        public string SandboxId { get; set; }

        /// <summary>
        /// Quantity granted with the purchase. Usually 1 but can be more if this is a consumable.
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// SkuId representing the specific sub-offering of the product that was purchased.
        /// </summary>
        [JsonProperty("skuId")]
        public string SkuId { get; set; }
    }
}


