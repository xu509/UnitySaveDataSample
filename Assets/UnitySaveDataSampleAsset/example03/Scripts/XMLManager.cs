using System.Collections;
using System.Collections.Generic; // lets us use lists
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class XMLManager : MonoBehaviour
{
    // singleton pattern
    public static XMLManager ins;

    void Awake()
    {
        ins = this;    
    }

    //list of items
    public ItemDataBase itemDB;

    //save function
    public void SaveItems() {
        // open a new xml file
        XmlSerializer serializer = new XmlSerializer(typeof(ItemDataBase));
        FileStream stream = new FileStream(Application.dataPath + "/UnitySaveDataSampleAsset/example03/StreamingFiles/XML/item_data.xml", FileMode.Create);
        serializer.Serialize(stream, itemDB);
        stream.Close();
    }

    // load function
    public void loadItems() {
        XmlSerializer serializer = new XmlSerializer(typeof(ItemDataBase));
        FileStream stream = new FileStream(Application.dataPath + "/UnitySaveDataSampleAsset/example03/StreamingFiles/XML/item_data.xml", FileMode.Open);
        itemDB = serializer.Deserialize(stream) as ItemDataBase;
        stream.Close();
    }

}

[System.Serializable]
public class ItemEntry {
    public string itemName;
    public Material material;
    public int value;
}

[System.Serializable]
public class ItemDataBase {

    //通过注解设置的字段会在XML根路径上使用
    [XmlArray("CombatEquipment")]
    public List<ItemEntry> list = new List<ItemEntry>();

}

public enum Material {
    Wood,Copper,Iron,Steel,Obsidian
}