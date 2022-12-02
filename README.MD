# UnityWebRequest

## Scene : JSONPlaceHolder

Example de requetes vers un WebAPI en tuilisant que les classes de Unity.

* UnityWebRequest
* JsonUtility

Voir ce post pour plus d'infos:
https://stackoverflow.com/questions/36239705/serialize-and-deserialize-json-and-json-array-in-unity

Ajout d'un JsonHelper pour récupérer des tableau d'objets.

Attention pour que ça fonctionne les tableau sont encapsulé dans un 

```json
{
    "Items" : [original array] 
}
```

### Prérequis

Les classes modeles doivent étre précédé par `[Serializable]` et les membres de la classes ne doivent pas être des property C#, avec le `{ set; get;} ` !

Example:

```csharp
[Serializable]
public class JSONPlaceHolderAddress
{
    public string street;
    public string suite;
    public string city;
    public string zipcode;
    public JSONPlaceHolderGeo geo;
}
```
