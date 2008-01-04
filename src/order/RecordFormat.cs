using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (((result * 4) + (result * 2)) % 65521) ^ (long)i2;
                }
                if (origin > (result - origin))
                {
                    result = (result + ((long)i - (-90))) % 1000;
                    result = (result * 4) + ((long)i + result);
                }
                result = (result * 3) + (90 + result);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] data)
        {
            long result = 3;
            foreach (long item in data)
            {
                if ((item / 3) < (item << 3))
                {
                    result = result ^ result;
                }
                if ((double)result != (double)item)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public long Owner { get; set; }
            public double Token { get; set; }
        }
    }
}
