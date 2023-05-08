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

import static com.konecranes.global.core.enums.I18nMessageScope.STOREFRONT
import static com.konecranes.global.core.i18n.LocaleEnum.EN
import static com.konecranes.global.patches.context.I18nMessageContext.i18n

PatchContextDescriber patch = patchContext

patch
        .description("Language selector")
        .i18nMessages(
                i18n("languageSelector.chooseLanguage", STOREFRONT)
                        .message(EN, "Choose language"),
        )
