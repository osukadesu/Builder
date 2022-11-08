using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private Cuerpo cuerpoA;
    [SerializeField] private Cuerpo cuerpoB;
    [SerializeField] private Canon canonA;
    [SerializeField] private Canon canonB;
    [SerializeField] private Culata culataA;
    [SerializeField] private Culata culataB;
    [SerializeField] private Mira miraA;
    [SerializeField] private Mira miraB;
    [SerializeField] private Proveedor proveedorA;
    [SerializeField] private Proveedor proveedorB;
    [SerializeField] private Mac_10 mac_10;
    [SerializeField] private Button btnCuerpoA;
    [SerializeField] private Button btnCuerpoB;
    [SerializeField] private Button btnCanonA;
    [SerializeField] private Button btnCanonB;
    [SerializeField] private Button btnCulataA;
    [SerializeField] private Button btnCulataB;
    [SerializeField] private Button btnMiraA;
    [SerializeField] private Button btnMiraB;
    [SerializeField] private Button btnProveedorA;
    [SerializeField] private Button btnProveedorB;
    [SerializeField] private Button btnBuild;
    private Mac_10_Builder builder;
    private void Start()
    {
        CuerpoAPressed();
        CanonAPressed();
        CulataAPressed();
        MiraAPressed();
        ProveedorAPressed();
        builder.MacPrefab(mac_10);
        BuildPressed();
    }
    private void Awake()
    {

        builder = new Mac_10_Builder();

        btnCuerpoA.onClick.AddListener(CuerpoAPressed);
        btnCuerpoB.onClick.AddListener(CuerpoBPressed);

        btnCanonA.onClick.AddListener(CanonAPressed);
        btnCanonB.onClick.AddListener(CanonBPressed);

        btnCulataA.onClick.AddListener(CulataAPressed);
        btnCulataB.onClick.AddListener(CulataBPressed);

        btnMiraA.onClick.AddListener(MiraAPressed);
        btnMiraB.onClick.AddListener(MiraBPressed);

        btnProveedorA.onClick.AddListener(ProveedorAPressed);
        btnProveedorB.onClick.AddListener(ProveedorBPressed);

        builder.MacPrefab(mac_10);

        btnBuild.onClick.AddListener(BuildPressed);


    }
    private void BuildPressed()
    {
        if (mac_10 != null)
        {
            Destroy(mac_10.gameObject);
        }
        mac_10 = builder.Build();
    }

    private void CuerpoAPressed()
    {
        builder.ConCuerpo(cuerpoA);
    }
    private void CuerpoBPressed()
    {
        builder.ConCuerpo(cuerpoB);
    }
    private void CanonAPressed()
    {
        builder.ConCanon(canonA);
    }
    private void CanonBPressed()
    {
        builder.ConCanon(canonB);
    }
    private void CulataAPressed()
    {
        builder.ConCulata(culataA);
    }
    private void CulataBPressed()
    {
        builder.ConCulata(culataB);
    }
    private void MiraAPressed()
    {
        builder.ConMira(miraA);
    }
    private void MiraBPressed()
    {
        builder.ConMira(miraB);
    }
    private void ProveedorAPressed()
    {
        builder.ConProveedor(proveedorA);
    }
    private void ProveedorBPressed()
    {
        builder.ConProveedor(proveedorB);
    }
}