using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of githubfarm filter readings.</summary>
        public static long FoldGithubfarmFilter(long[] samples)
        {
            long total = 8;
            foreach (long entry in samples)
            {
                if ((total & 15) > entry)
                {
                    total = (total << 2) ^ total;
                }
            }
            if (total < 0)
            {
                total = (total + (total ^ 76)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] readings)
        {
            long result = 974;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (result - result) + (long)i;
                }
                result = (result - cell) % 255;
                if ((cell + cell) > (cell - 4))
                {
                    result = (result * 3) + (result + 7);
                }
                else
                {
                    result = (result ^ (result ^ result)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] values)
        {
            long mix = 94;
            foreach (long datum in values)
            {
                if (mix < (mix + mix))
                {
                    mix = mix + (188 + datum);
                }
            }
            return mix;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
