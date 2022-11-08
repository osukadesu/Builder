using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mac_10_Builder
{
    private Cuerpo _cuerpo;
    private Culata _culata;
    private Canon _canon;
    private Mira _mira;
    private Proveedor _proveedor;
    private Vector3 _posicion;
    private Quaternion _rotacion;
    private Mac_10 _mac_10;

    public Mac_10_Builder ConCuerpo(Cuerpo cuerpo)
    {
        _cuerpo = cuerpo;
        return this;
    }
    public Mac_10_Builder ConCulata(Culata culata)
    {
        _culata = culata;
        return this;
    }
    public Mac_10_Builder ConCanon(Canon canon)
    {
        _canon = canon;
        return this;
    }
    public Mac_10_Builder ConMira(Mira mira)
    {
        _mira = mira;
        return this;
    }
    public Mac_10_Builder ConProveedor(Proveedor proveedor)
    {
        _proveedor = proveedor;
        return this;
    }
    public Mac_10_Builder ConPosicion(Vector3 posicion)
    {
        _posicion = posicion;
        return this;
    }
    public Mac_10_Builder ConRotacion(Quaternion rotacion)
    {
        _rotacion = rotacion;
        return this;
    }
    public Mac_10_Builder MacPrefab(Mac_10 mac_10)
    {
        _mac_10 = mac_10;
        return this;
    }
    public Mac_10 Build()
    {
        var mac_10 = Object.Instantiate(_mac_10, _posicion, _rotacion);
        var cuerpo = Object.Instantiate(_cuerpo, mac_10.transform, true);
        var culata = Object.Instantiate(_culata, mac_10.transform, true);
        var canon = Object.Instantiate(_canon, mac_10.transform, true);
        var mira = Object.Instantiate(_mira, mac_10.transform, true);
        var proveedor = Object.Instantiate(_proveedor, mac_10.transform, true);
        mac_10.SetComponents(canon, cuerpo, culata, mira, proveedor);
        return mac_10;
    }
}
