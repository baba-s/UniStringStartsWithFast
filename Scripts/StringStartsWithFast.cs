namespace Kogane
{
	/// <summary>
	/// 高速な string.StartsWith と string.EndsWith を管理するクラス
	/// http://baba-s.hatenablog.com/entry/2017/12/07/090000
	/// https://docs.unity3d.com/ja/current/Manual/BestPracticeUnderstandingPerformanceInUnity5.html
	/// </summary>
	public static class StringStartsWithFast
	{
		//================================================================================
		// 関数(static)
		//================================================================================
		/// <summary>
		/// string.StartsWith よりも高速な StartsWith
		/// </summary>
		public static bool StartsWithFast( this string a, string b )
		{
			int aLen = a.Length;
			int bLen = b.Length;
			int ap   = 0;
			int bp   = 0;

			while ( ap < aLen && bp < bLen && a[ ap ] == b[ bp ] )
			{
				ap++;
				bp++;
			}

			return ( bp == bLen && aLen >= bLen ) || ( ap == aLen && bLen >= aLen );
		}

		/// <summary>
		/// string.EndsWith よりも高速な EndsWith
		/// </summary>
		public static bool EndsWithFast( this string a, string b )
		{
			int ap = a.Length - 1;
			int bp = b.Length - 1;

			while ( ap >= 0 && bp >= 0 && a[ ap ] == b[ bp ] )
			{
				ap--;
				bp--;
			}

			return ( bp < 0 && a.Length >= b.Length ) || ( ap < 0 && b.Length >= a.Length );
		}
	}
}