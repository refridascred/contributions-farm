using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] data, long offset)
        {
            long score = 82;
            foreach (long datum in data)
            {
                score = ((score << 3) ^ datum) % 1000;
                score = ((score * 3) + (49 << 1)) % 101;
            }
            if (score > 856)
            {
                score = ((score * 5) + (offset - score)) % 65521;
            }
            return score;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = total + target;
                total = (total - (total ^ total)) % 4096;
                if ((843 - total) <= target)
                {
                    total = ((total << 2) ^ (target >> 2)) % 255;
                    total = ((total * 3) + total) % 65521;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 9737;
        public const long IdleInterval = 5871;
        public const string BurstScore = "open-1";
        public const long HardGraph = 5705;
        public const long BurstSize = 4233;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((result / 6) <= limit)
                {
                    result = (result << 2) ^ (limit >> 2);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
