﻿using System.Collections.Generic;

namespace Clients
{
    public static class Dialogues
    {
        public static Dictionary<string, string[]> Phrases =
            new Dictionary<string, string[]>
            {
                { "Abigaile", new[]
                        {
                            "Мой друг-<color=red><link=египтолог>египтолог</link></color> шутил, что нам следует",
                            "устроить ему <color=red><link=королевские похороны>королевские</link></color>" +
                            "<color=red><link=королевские похороны> похороны</link></color>.",
                            "Думаю, он был бы рад, если бы мы так и сделали.",
                            "Однако с практической точки зрения",
                            "идея <color=red><link=кремация>кремации</link></color> всегда привлекала его больше.",
                            "Если можно, назначьте прощание на <color=red><link=7 мая>7</link></color> <color=red><link=7 мая>мая</link></color>.",
                            "Если это важно, он <color=red><link=не религиозен>не</link></color> " +
                            "<color=red><link=не религиозен>был</link></color> <color=red><link=не религиозен>религиозен</link></color>."

                        } 
                },
                { "Harold", new []
                    {
                        "Кхе-кхем... супруга моя почила на днях...",
                        "Боюсь только, как бы из могилы не встала...",
                        "<color=red><link=кремация>Кремация</link></color> - хорошо, но не " +
                        "<color=red><link=христианин?>по-христиански</link></color> это.",
                        "Вот кладбище бы где-нибудь у <color=red><link=церковь>церкви</link></color>, кхе-кхем...",
                        "<color=red><link=отпевание>Священника</link></color>, ясное дело...",
                        "Да <color=red><link=больше крестов>крестов</link></color> побольше, да...",
                        "Три дня надо подождать, это, получается, <color=red><link=9 мая>9</link></color> " +
                        "<color=red><link=9 мая>мая</link></color> будет, кхе-кхем..."
                    }
                }
            };
    }
}