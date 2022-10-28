//Este código se encarga de que el cambio de idioma funcione correctamente
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class ChangeLanguage: MonoBehaviour {

    int idioma = 5;
    const int kIdiomaOg = 5;

    private void Start () {
        SelectCurrentLanguage ();
    }

    void SelectCurrentLanguage () {
        UnityEngine.Localization.Locale searcher = LocalizationSettings.AvailableLocales.Locales[idioma];

        while (searcher != LocalizationSettings.SelectedLocale && idioma < LocalizationSettings.AvailableLocales.Locales.Count) {
            ++idioma;
            searcher = LocalizationSettings.AvailableLocales.Locales[idioma];
        }

    }

    public void SwipeRight () {
        ++idioma;
        if (idioma >= LocalizationSettings.AvailableLocales.Locales.Count)
            idioma = 0;
        Debug.Log (idioma);
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idioma];
    }

    public void SwipeLeft () {
        --idioma;
        if (idioma < 0)
            idioma = kIdiomaOg;
        Debug.Log (idioma);
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idioma];
    }
}
