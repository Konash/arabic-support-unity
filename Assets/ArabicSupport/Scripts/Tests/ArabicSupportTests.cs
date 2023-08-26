using System;
using ArabicSupport;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ArabicSupportTests
{
    [TestCase("< الربيعة >", "< ﺔﻌﻴﺑﺮﻟا >")]
    [TestCase("00966-5022", "٠٠٩٦٦-٥٠٢٢")]
    [TestCase("100 - 70 = 30", "٣٠ = ٧٠ - ١٠٠")]
    [TestCase("سؤلك سألك سائل مسألة مآل ساءت ملء", "ءﻞﻣ تءﺎﺳ لﺂﻣ ﺔﻟﺄﺴﻣ ﻞﺋﺎﺳ ﻚﻟﺄﺳ ﻚﻟﺆﺳ")]
    [TestCase("جولة إضافية في 80,000", "٨٠,٠٠٠ ﻲﻓ ﺔﻴﻓﺎﺿإ ﺔﻟﻮﺟ")]
    [TestCase("وَأَيْضاً نَدْعَمُ الحَرَكَات وَالأَرْقَام 0123456789", "٠١٢٣٤٥٦٧٨٩ مﺎﻗرﻷاو تﺎﻛﺮﺤﻟا ﻢﻋﺪﻧ ﺎﻀﻳأو")]
    [TestCase("00966 5022", "٠٠٩٦٦ ٥٠٢٢")]
    [TestCase("أحمل(أحمد) ()", ")( (ﺪﻤﺣأ)ﻞﻤﺣأ")]
    [TestCase("tooooبل", "ﻞﺒtoooo")]
    [TestCase("349857^3459", "٣٤٩٨٥٧^٣٤٥٩")]
    [TestCase("إنتهت الجولة!", "!ﺔﻟﻮﺠﻟا ﺖﻬﺘﻧإ")]
    [TestCase("عربي bonus round at 80,000 هع", "ﻊﻫ bonus round at ٨٠,٠٠٠ ﻲﺑﺮﻋ")]
    [TestCase("جولة 2", "٢ ﺔﻟﻮﺟ")]
    [TestCase("المخاوي999", "٩٩٩يوﺎﺨﻤﻟا")]
    [TestCase("تجربة سطرين\nمع بعض", "ﻦﻳﺮﻄﺳ ﺔﺑﺮﺠﺗ\nﺾﻌﺑ ﻊﻣ")]
    [TestCase("(نص عربي، أهلا.)", ".(ﻼﻫأ ،ﻲﺑﺮﻋ ﺺﻧ)")]
    [TestCase("10,000", "١٠,٠٠٠")]
    [TestCase("العمدة <من9> <ل>", "<ل> ٩<ﻦﻣ> ةﺪﻤﻌﻟا")]
    [TestCase("الشيء امرأة مرء الء", "ءلا ءﺮﻣ ةأﺮﻣا ءﻲﺸﻟا")]
    [TestCase("[أبو شيحة]", "[ﺔﺤﻴﺷ ﻮﺑأ]")]
    [TestCase("الأعداد هي: 44 ، 66 ، 88 على التوالي", "ﻲﻟاﻮﺘﻟا ﯽﻠﻋ ٨٨ ، ٦٦ ، ٤٤ :ﻲﻫ داﺪﻋﻷا")]
    [TestCase("ىىى تعالى", "ﯽﻟﺎﻌﺗ ﯽﯿﯾ")]
    [TestCase("الجدُّ منسِّق عمَّان", "ﱠنﺎﻤﻋ ﱢﻖﺴﻨﻣ ﱡﺪﺠﻟا", true)]
    [TestCase("كفاءتها", "ﺎﻬﺗءﺎﻔﻛ")]
    [TestCase("س°س", "س°س")]
    public void TextFix(string entryText, string expectedText, bool showTashkeel = false, bool useHinduNumbers = true)
    {
        expectedText = expectedText.Replace("\n", Environment.NewLine);
        
        var fixedText = ArabicFixer.Fix(entryText, showTashkeel, useHinduNumbers);
        Assert.AreEqual(expectedText, fixedText);
    }
}
