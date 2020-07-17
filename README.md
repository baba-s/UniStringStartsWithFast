# UniStringStartsWithFast

通常の string.StartsWith、string.EndsWith よりも高速な StartsWith、EndsWith

## 使用例

### 通常

```cs
if ( str.StartsWith( "http://" ) )
{
}

if ( str.EndsWith( ".png" ) )
{
}
```

### UniStringStartsWithFast

```cs
if ( str.StartsWithFast( "http://" ) )
{
}

if ( str.EndsWithFast( ".png" ) )
{
}
```

## 参考サイト様

- https://docs.unity3d.com/ja/current/Manual/BestPracticeUnderstandingPerformanceInUnity5.html  
