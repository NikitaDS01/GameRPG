using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Items;
using Dialog;

namespace GameRPG
{
    public static class File_System
    {
        private static string PATH_DIALOG = Json_System.Path+@"Dialog\";
        private static string PATH_ITEM = Json_System.Path + @"Item\";
        public static void SaveDialog(UnitDialog dialog, string nameFile)
        {
            Json_System.SaveObject(dialog, Json_System.FilePath(PATH_DIALOG, nameFile));
        }
        public static UnitDialog LoadDialog(string nameFile)
        {
            UnitDialog dialog = Json_System.LoadObject<UnitDialog>(Json_System.FilePath(PATH_DIALOG, nameFile));
            if (dialog is null) return new UnitDialog("", "");
            return dialog;
        }
        private static void SaveItem<T>(T _object, string nameFile)
        {
            List<T> list = Json_System.LoadObject<List<T>>(Json_System.FilePath(PATH_ITEM, nameFile));
            if(list is null) return;
            list.Add(_object);
            Json_System.SaveObject(_object, Json_System.FilePath(PATH_ITEM, nameFile));
        }
        public static void SaveWeapon(Weapon _object)=>SaveItem(_object, "Weapon");
        public static void SaveArtifact(Artifact _object) => SaveItem(_object, "Artifact");
        public static void SaveMaterial(Material _object) => SaveItem(_object, "Material");
        private static List<T> LoadItem<T>(string nameFile)
        {
            List<T> list = Json_System.LoadObject<List<T>>(Json_System.FilePath(PATH_ITEM, nameFile));
            if (list is null) return new List<T>();
            return list;            
        }
        public static List<Weapon> LoadWeapon() => LoadItem<Weapon>("Weapon");
        public static List<Artifact> LoadArtifact() => LoadItem<Artifact>("Artifact");
        public static List<Material> LoadMaterial() => LoadItem<Material>("Material");
    }
}