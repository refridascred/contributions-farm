using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the editor order series from a seed.</summary>
        public static long StepEditorOrder(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!((result + floor) >= result))
                {
                    result = (result + (floor ^ (long)i)) % 97;
                }
                result = ((result * 5) + (floor >> 1)) % 101;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the checks payload entries that pass the check.</summary>
        public static long TallyChecksPayloadGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((entry >> 1) == (entry / 5)) && (entry > (seen - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "open-1";
        public const double DefaultGraph = 2.76;
        public const long DefaultCount = 2382;
        public const long IdleGraph = 6425;

        /// <summary>Fold a list of batch tools readings.</summary>
        public static long TallyBatchTools(long[] samples)
        {
            long sum = 8;
            foreach (long reading in samples)
            {
                sum = (sum ^ (sum / 4)) ^ reading;
            }
            return sum;
        }
    }
}
