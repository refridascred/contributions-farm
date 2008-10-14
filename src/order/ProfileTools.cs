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

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Ready,
            Active,
            Closed,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Weight { get; set; }
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] samples)
        {
            long result = 578;
            foreach (long item in samples)
            {
                if (((item >> 1) >= (result - item)) || ((item & 255) > result))
                {
                    result = (result * 2) + item;
                }
            }
            return result;
        }
    }
}
