/*
 * [y] hybris Platform
 *
 * Copyright (c) 2018-2022 Konecranes
 * All Rights Reserved.
 *
 * Suppliers:
 *  - Bilot Oyj (2018 - .)
 *  - Solteq Oyj (2019 - .)
 *  - Tieto Oyj (2018 - 2019)
 *
 * This software is the confidential and proprietary information
 * of Konecranes and its suppliers, if any.
 * The intellectual and technical concepts contained herein
 * are proprietary to Konecranes and its suppliers and may be covered by Patents,
 * patents in process, and are protected by trade secret or copyright law.
 * Dissemination of this information or reproduction of this material
 * is strictly forbidden unless prior written permission is obtained from Konecranes.
 */

import com.konecranes.global.patches.context.patch.PatchContextDescriber
import com.konecranes.patches.groovy.ContentCatalogEnum
import static com.konecranes.global.core.enums.I18nMessageScope.STOREFRONT
import static com.konecranes.global.core.i18n.LocaleEnum.EN
import static com.konecranes.global.patches.context.I18nMessageContext.i18n

PatchContextDescriber patch = patchContext

patch
    .description("Orders component in the front page")
    .withImpexes(
        "cms-responsive-content.impex"
    ).syncContentCatalogs(ContentCatalogEnum.KC_PORTAL)
    .i18nMessages(
        i18n("orders.title", STOREFRONT)
            .message(EN, "Orders"),
        i18n("orders.results", STOREFRONT)
            .message(EN, "Top {{pageSize}} out of {{totalResults}} orders"),
        i18n("orders.details.more", STOREFRONT)
            .message(EN, "More information"),
        i18n("orders.details.less", STOREFRONT)
            .message(EN, "Less information"),
        i18n("orders.details.rescheduled", STOREFRONT)
            .message(EN, "One or more items in this order have been rescheduled. Please <u>check the item list</u> for the new dates."),
        i18n("orders.details.contact", STOREFRONT)
            .message(EN, "You can <b>contact us</b> through chat."),
        i18n("orderHistory.order", STOREFRONT)
            .message(EN, "Order"),
        i18n("orderHistory.orderDate", STOREFRONT)
            .message(EN, "Order date"),
        i18n("orderHistory.shippingDate", STOREFRONT)
            .message(EN, "Shipping date"),
        i18n("orderHistory.status", STOREFRONT)
            .message(EN, "Status"),
        i18n("orderHistory.quotationNo", STOREFRONT)
            .message(EN, "Quotation no"),
        i18n("orderHistory.customerPo", STOREFRONT)
            .message(EN, "Customer PO"),
        i18n("orderHistory.customerReference", STOREFRONT)
            .message(EN, "Customer refence"),
        i18n("orderHistory.projectNumber", STOREFRONT)
            .message(EN, "Project number"),
        i18n("orderHistory.webOrderNumber", STOREFRONT)
            .message(EN, "Web order number"),
        i18n("order.status.OPEN", STOREFRONT)
            .message(EN, "Open"),
        i18n("order.status.CONFIRMED", STOREFRONT)
            .message(EN, "Confirmed"),
        i18n("order.status.PARTIALLY_SHIPPED", STOREFRONT)
            .message(EN, "Partially shipped"),
        i18n("order.status.SHIPPED", STOREFRONT)
            .message(EN, "Shipped"),
        i18n("order.status.CONTACT_US", STOREFRONT)
            .message(EN, "Contact us"),
        i18n("order.status.CANCELLED", STOREFRONT)
            .message(EN, "Cancelled"),
    )
