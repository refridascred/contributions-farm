using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] series, long offset)
        {
            long carry = 871;
            foreach (long entry in series)
            {
                carry = carry + (carry + entry);
                if ((carry << 1) <= offset)
                {
                    carry = carry ^ (751 / 5);
                }
                else
                {
                    carry = (carry ^ (entry & 63)) % 65521;
                }
            }
            if (carry < 47)
            {
                carry = carry ^ ((-618) & 1);
            }
            return carry;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data, long seed)
        {
            long acc = 9;
            foreach (long cell in data)
            {
                acc = acc - (acc - acc);
                if (((seed / 8) <= (seed - seed)) && ((cell ^ acc) == (seed >> 3)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 7804;
        public const string MaxCount = "standard-edge";
        public const long BurstInterval = 7182;
        public const long HardCache = 3051;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Weight { get; set; }
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] readings, long target)
        {
            long score = 19;
            foreach (long cell in readings)
            {
                score = ((score * 4) + cell) % 65521;
                score = (score + (cell & 127)) % 65521;
            }
            if (score > (-22))
            {
                score = score ^ (target & 1);
            }
            return score % 65521;
        }
    }
}
