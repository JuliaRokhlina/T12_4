using System.Collections.Generic;

namespace Game
{
    public static partial class GameState
    {
        private static void SetGameObjects()
                {
                    Containers = GetContainers();
                    Gravestones = GetGravestones();
                    Wreaths = GetWreaths();
                    CustomersToday = customersByDays[Day];;
                }
        
                //Add objects here
        
                private static List<Container> GetContainers()
                {
	                return new List<Container>
	                {
		                new Container(
			                ContainerTypes.Coffin,
			                "Sprites/coffin_5",
			                "Деревянный",
			                20),
		                new Container(
			                ContainerTypes.Coffin,
			                "Sprites/coffin_6",
			                "С крестом",
			                30,
			                ContainerStyles.Cross),
		                new Container(
			                ContainerTypes.Coffin,
			                "Sprites/coffin_4",
			                "Саркофаг",
			                80,
			                ContainerStyles.Rich),
		                new Container(
			                ContainerTypes.Coffin,
			                "Sprites/coffin_7",
			                "Комфорт",
			                50,
			                ContainerStyles.Comfort),
		                new Container(
			                ContainerTypes.Coffin,
			                "Sprites/coffin_8",
			                "Патриот",
			                30,
			                ContainerStyles.Flag),
		                new Container(
			                ContainerTypes.Coffin,
			                "Sprites/coffin_9",
			                "[Error 404]",
			                80,
			                ContainerStyles.Color),
		                
		                new Container(
			                ContainerTypes.Urn,
			                "Sprites/urn_1",
			                "Классика",
			                10),
		                new Container(
			                ContainerTypes.Urn,
			                "Sprites/urn_3",
			                "Яркая",
			                15,
			                ContainerStyles.Color),
		                new Container(
			                ContainerTypes.Urn,
			                "Sprites/urn_2",
			                "Ар-деко",
			                25,
			                ContainerStyles.Rich)
	                };
                }
        
                private static List<Attribute> GetGravestones()
                {
	                return new List<Attribute>
	                {
		                new Attribute(
			                AttributeTypes.Gravestone,
			                "Sprites/stone_1",
			                "Кельтский крест",
			                50),
		                new Attribute(
			                AttributeTypes.Gravestone,
			                "Sprites/stone_2",
			                "Готика",
			                40),
		                new Attribute(
			                AttributeTypes.Gravestone,
			                "Sprites/stone_3",
			                "Классика",
			                30)
	                };
                }
        
                private static List<Attribute> GetWreaths()
                {
	                return new List<Attribute>
	                {
		                new Attribute(
			                AttributeTypes.Wreath,
			                "Sprites/Венок",
			                "Лилии",
			                10),
		                new Attribute(
			                AttributeTypes.Wreath,
			                "Sprites/Венок2",
			                "Сердце",
			                15),
		                new Attribute(
			                AttributeTypes.Wreath,
			                "Sprites/Венок3",
			                "Овальный",
			                20)
	                };
                }
    }
}