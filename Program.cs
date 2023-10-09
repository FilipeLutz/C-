
using LotteryApp.concrete;
using LotteryApp.Constants;

Console.WriteLine(LotteryConstants.APPLICATION_NAME);

IrishLotto irishLotto = new IrishLotto();

List<int> numbers = irishLotto.GenerateLotteryNumbers();

foreach (var number in numbers)
{
    Console.WriteLine(number);
}
Console.WriteLine();