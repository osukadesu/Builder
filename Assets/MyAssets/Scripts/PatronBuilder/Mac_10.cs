using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mac_10 : MonoBehaviour
{
    private Canon _canon;
    private Cuerpo _cuerpo;
    private Culata _culata;
    private Mira _mira;
    private Proveedor _proveedor;

    public void SetComponents(Canon canon, Cuerpo cuerpo, Culata culata, Mira mira, Proveedor proveedor)
    {
        _canon = canon;
        _cuerpo = cuerpo;
        _culata = culata;
        _mira = mira;
        _proveedor = proveedor;
    }
}
