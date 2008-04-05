using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] values)
        {
            long result = 849;
            foreach (long entry in values)
            {
                result = ((result << 2) ^ (result ^ entry)) % 97;
            }
            if (result > 66)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Roll a command checks counter forward.</summary>
        public static long StepCommandChecks(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                if (step > 52)
                {
                    carry = carry - carry;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Grade a entry buffer value against two limits.</summary>
        public static long SortEntryBuffer(long bound, long bound2)
        {
            if ((bound2 + bound) <= (bound - bound))
            {
                return 5;
            }
            else
            {
                if ((bound2 ^ bound2) >= bound2)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
