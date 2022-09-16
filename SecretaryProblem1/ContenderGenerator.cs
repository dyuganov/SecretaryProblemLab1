﻿using System.Security.Cryptography;

namespace SecretaryProblem1;

public class ContenderGenerator
{
    private const uint ContenderAmount = 100;
    private const uint MinValue = 1;
    private const uint MaxValue = 100;
    private readonly Random _rand = new Random();

    private readonly String[] _names = 
    {
        "Авдей", "Авксентий", "Агапит", "Агафон", "Акакий", 
        "Акиндин", "Александр", "Алексей", "Альберт", "Альвиан",
        "Анатолий", "Андрей", "Аникита", "Антон", "Антонин", 
        "Анфим", "Аристарх", "Аркадий", "Арсений", "Артём",
        "Артемий", "Артур", "Архипп", "Афанасий", "Богдан",
        "Борис", "Вавила", "Вадим", "Валентин", "Валерий",
        "Валерьян", "Варлам", "Варсонофий", "Варфоломей", "Василий",
        "Венедикт", "Вениамин", "Викентий", "Виктор", "Виссарион",
        "Виталий", "Владимир", "Владислав", "Владлен", "Влас",
        "Всеволод", "Вячеслав", "Гавриил", "Галактион", "Геласий",
        "Геннадий", "Георгий", "Герасим", "Герман", "Германн",
        "Глеб", "Гордей", "Григорий", "Данакт", "Даниил",
        "Демид", "Демьян", "Денис", "Дмитрий", "Добрыня",
        "Донат", "Дорофей", "Евгений", "Евграф", "Евдоким",
        "Евсей", "Евстафий", "Егор", "Емельян", "Еремей",
        "Ермолай", "Ерофей", "Ефим", "Ефрем", "Ждан",
        "Зиновий", "Иакинф", "Иван", "Игнатий", "Игорь",
        "Изот", "Илья", "Иннокентий", "Ираклий", "Ириней",
        "Исидор", "Иуда", "Иулиан", "Капитон", "Ким",
        "Кир", "Кирилл", "Климент", "Кондрат", "Конон",
        "Константин", "Корнилий", "Кузьма", "Куприян", "Лаврентий",
        "Лев", "Леонид", "Леонтий", "Логгин", "Лука",
        "Лукий", "Лукьян", "Магистриан", "Макар", "Максим",
        "Мамонт", "Марк", "Мартын", "Матвей", "Мелентий", 
        "Мина", "Мирослав", "Митрофан", "Михаил", "Мстислав",
        "Назар", "Нестор", "Никандр", "Никанор", "Никита",
        "Никифор", "Никодим", "Николай", "Никон"
    };

    private readonly String[] _surnames =
    {
        "Абрамов", "Авдеев", "Агафонов", "Аксёнов", "Александров",
        "Алексеев", "Андреев", "Анисимов", "Антонов", "Артемьев",
        "Архипов", "Афанасьев", "Баранов", "Белов", "Белозёров",
        "Белоусов", "Беляев", "Беляков", "Беспалов", "Бирюков",
        "Блинов", "Блохин", "Бобров", "Бобылёв", "Богданов",
        "Большаков", "Борисов", "Брагин", "Буров", "Быков",
        "Васильев", "Веселов", "Виноградов", "Вишняков", "Владимиров",
        "Власов", "Волков", "Воробьёв", "Воронов", "Воронцов",
        "Гаврилов", "Галкин", "Герасимов", "Голубев", "Горбачёв",
        "Горбунов", "Гордеев", "Горшков", "Григорьев", "Гришин",
        "Громов", "Гуляев", "Гурьев", "Гусев", "Гущин",
        "Давыдов", "Данилов", "Дементьев", "Денисов", "Дмитриев",
        "Доронин", "Дорофеев", "Дроздов", "Дьячков", "Евдокимов",
        "Евсеев", "Егоров", "Елисеев", "Емельянов", "Ермаков",
        "Ершов", "Ефимов", "Ефремов", "Жданов", "Жуков",
        "Журавлёв", "Зайцев", "Захаров", "Зимин", "Зиновьев",
        "Зуев", "Зыков", "Иванков", "Иванов", "Игнатов",
        "Игнатьев", "Ильин", "Исаев", "Исаков", "Кабанов",
        "Казаков", "Калашников", "Калинин", "Капустин", "Карпов",
        "Кириллов", "Киселёв", "Князев", "Ковалёв", "Козлов",
        "Колесников", "Колобов", "Комаров", "Комиссаров", "Кондратьев",
        "Коновалов", "Кононов", "Константинов", "Копылов", "Корнилов",
        "Королёв", "Костин", "Котов", "Кошелев", "Красильников",
        "Крылов", "Крюков", "Кудрявцев", "Кудряшов", "Кузнецов",
        "Кузьмин", "Кулагин", "Кулаков", "Куликов", "Лаврентьев",
        "Лазарев", "Лапин", "Ларионов", "Лебедев", "Лихачёв",
        "Лобанов", "Логинов", "Лукин", "Лыткин", "Макаров",
        "Максимов", "Мамонтов", "Марков", "Мартынов", "Маслов",
        "Матвеев", "Медведев", "Мельников", "Меркушев", "Миронов",
        "Михайлов", "Михеев", "Мишин", "Моисеев", "Молчанов",
        "Морозов", "Муравьёв", "Мухин", "Мышкин", "Мясников",
        "Назаров", "Наумов", "Некрасов", "Нестеров", "Никитин",
        "Никифоров", "Николаев", "Никонов", "Новиков", "Носков",
        "Носов", "Овчинников", "Одинцов", "Орехов", "Орлов",
        "Осипов", "Павлов", "Панов", "Панфилов", "Пахомов",
        "Пестов", "Петров", "Петухов", "Поляков", "Пономарёв",
        "Попов", "Потапов", "Прохоров", "Рогов", "Родионов",
        "Рожков", "Романов", "Русаков", "Рыбаков", "Рябов",
        "Савельев", "Савин", "Сазонов", "Самойлов", "Самсонов",
        "Сафонов", "Селезнёв", "Селиверстов", "Семёнов", "Сергеев",
        "Сидоров", "Силин", "Симонов", "Ситников", "Соболев",
        "Соколов", "Соловьёв", "Сорокин", "Степанов", "Стрелков",
        "Субботин", "Суворов", "Суханов", "Сысоев", "Тарасов",
        "Терентьев", "Тетерин", "Тимофеев", "Титов", "Тихонов",
        "Третьяков", "Трофимов", "Туров", "Уваров", "Устинов",
        "Фадеев", "Фёдоров", "Федосеев", "Федотов", "Филатов",
        "Филиппов", "Фокин", "Фомин", "Фомичёв", "Фролов",
        "Харитонов", "Хохлов", "Цветков", "Чернов", "Шарапов",
        "Шаров", "Шашков", "Шестаков", "Шилов", "Ширяев",
        "Шубин", "Щербаков", "Щукин", "Юдин", "Яковлев"
    };

    public List<Contender> GenerateContenders(int amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Wrong amount for Contender generator");
        }
        List<Contender> contenders = new List<Contender>();
        for (int i = 0; i < amount; ++i)
        {
            contenders.Add(new Contender(GetRandomName(), GetRandomSurname(), i));
        }
        return contenders.OrderBy(item => _rand.Next()).ToList();
    }

    private String GetRandomName(){
        return _names[_rand.Next(_names.Length)];
    }

    private String GetRandomSurname()
    {
        return _surnames[_rand.Next(_surnames.Length)];
    }
}