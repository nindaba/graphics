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
    .description("User profile")
    .withImpexes(
        "cms-responsive-content.impex"
    ).syncContentCatalogs(ContentCatalogEnum.KC_PORTAL)
    .i18nMessages(
        i18n("updateProfileForm.companyName", STOREFRONT)
            .message(EN, "Company name"),
        i18n("updateProfileForm.customerId", STOREFRONT)
            .message(EN, "Customer number"),
        i18n("updateProfileForm.firstName.label", STOREFRONT)
            .message(EN, "First name"),
        i18n("updateProfileForm.firstName.placeholder", STOREFRONT)
            .message(EN, "First name"),
        i18n("updateProfileForm.lastName.label", STOREFRONT)
            .message(EN, "Last name"),
        i18n("updateProfileForm.lastName.placeholder", STOREFRONT)
            .message(EN, "Last name"),
        i18n("updateProfileForm.title", STOREFRONT)
            .message(EN, "Salutation"),
        i18n("updateProfileForm.none", STOREFRONT)
            .message(EN, " "),
        i18n("updateProfileForm.telephone.label", STOREFRONT)
            .message(EN, "Telephone"),
        i18n("updateProfileForm.telephone.placeholder", STOREFRONT)
            .message(EN, "Telephone"),
        i18n("updateProfileForm.mobile.label", STOREFRONT)
            .message(EN, "Mobile"),
        i18n("updateProfileForm.mobile.placeholder", STOREFRONT)
            .message(EN, "Mobile"),
        i18n("updateProfileForm.email", STOREFRONT)
            .message(EN, "Email"),
        i18n("updateProfileForm.unsubscribe", STOREFRONT)
            .message(EN, "I want to unsubscribe from ticketing email notifications"),
        i18n("updateProfileForm.cancel", STOREFRONT)
            .message(EN, "Continue without saving"),
        i18n("updateProfileForm.save", STOREFRONT)
            .message(EN, "Save changes"),
    )
