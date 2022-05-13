using System;
using Arrays.Problems;
using Xunit;
using FluentAssertions;

namespace ArraysTests;

public class RemoveDuplicatesFromSortedArrayTests
{
    [Fact]
    public void GetLengthForArrayWithDuplicate()
    {
        // создаем тестовые данные
        var array = new[] {1, 1, 2};
        var solution = new RemoveDuplicatesFromSortedArray();

        // вызываем код который необходимо проверить
        var countOfNumber = solution.RemoveDuplicates(array);

        // проверяем что результат соответствует ожидаемому значению
        // используется библиотека FluentAssertions, подробнее ознакомится можно тут https://fluentassertions.com/introduction
        countOfNumber.Should().Be(2);
    }
    
    [Fact]
    public void GetLengthForArrayWithMultipleDuplicate()
    {
        var array = new[] {1, 1, 2, 3, 4, 3, 5, 1, 2};
        var solution = new RemoveDuplicatesFromSortedArray();

        var countOfNumber = solution.RemoveDuplicates(array);

        countOfNumber.Should().Be(5);
    }
    
    [Fact]
    public void GetZeroForEmptyArray()
    {
        var array = Array.Empty<int>();
        var solution = new RemoveDuplicatesFromSortedArray();

        var countOfNumber = solution.RemoveDuplicates(array);

        countOfNumber.Should().Be(0);
    }
    
    [Fact]
    public void GetLengthForArrayWithoutDuplicate()
    {
        var array = new[] {1, 2, 3, 4, 5};
        var solution = new RemoveDuplicatesFromSortedArray();

        var countOfNumber = solution.RemoveDuplicates(array);

        countOfNumber.Should().Be(5);
    }
}