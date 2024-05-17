using System.Collections.Generic;

public static class LinkedListExtensions {
    public static IEnumerable<T> AsEnumerable<T>(this IEnumerator<T> enumerator) {
        while (enumerator.MoveNext()) {
            yield return enumerator.Current;
        }
    }
}
