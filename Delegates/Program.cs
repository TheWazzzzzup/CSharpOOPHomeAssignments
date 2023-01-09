/*
 * Create a generic Binary Tree
 * Tree Will Hold 3 fields
 * 1. generic Self; 2. Generic Left; 3.Generic Right (Left and right may use the same Generic but it is kind of cool if they wont)
 * Research some more on IEnumerable and IEnumrator 
 * Create depth-first search, searches Each Branch childs and then moves on
 * create Breadth-first search, showes each level then moves 
 */

/// <summary>
/// 
/// </summary>
/// <typeparam name="T1">The self defined value of said branch</typeparam>
/// <typeparam name="T2">The Type of the Branch</typeparam>
class Stem<T1,T2>
{
    T1 Identity { get; set; }

    T2 LeftChild { get; set; }
    T2 RightChild { get; set; }
}