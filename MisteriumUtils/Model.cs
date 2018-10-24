using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json;

namespace MisteriumUtils
{
    public class DataBaseObj
    {
        public string Name { get; set; }

        /// <summary>
        /// Тип объекта. Класс/Владение оружием/Магия...
        /// </summary>
        public string ObjType { get; set; }
        
        /// <summary>
        /// Список способностей
        /// </summary>
        public List<Property> PropertyList { get; set; }
    }

    public class Property
    {
        public string NameAbility { get; set; }

        public AbilityLevelProperty SelectedAbility { get; set; }

        /// <summary>
        /// Список уровней спосбоности и отдельно абилки каждого уровня.
        /// </summary>
        public List<AbilityLevelProperty> PropertyDescription { get; set; }
    }

    public class AbilityLevelProperty
    {
        /// <summary>
        /// Уровень, в котором находится свойство
        /// </summary>
        public int? Level { get; set; }

        /// <summary>
        /// Является ли способность уникальной.
        /// </summary>
        public bool IsUnique { get; set; }

        /// <summary>
        /// Тип свойства (атакующее/защитное...)
        /// </summary>
        public string TypeProperty { get; set; }

        /// <summary>
        /// C чем складывается сила (атака/точность/защита...)
        /// </summary>
        public string WithWhatDevelops { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Значение для вычисления
        /// </summary>
        public int Value { get; set; }
    }
}
