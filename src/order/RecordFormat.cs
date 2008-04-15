using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a support queue value against two limits.</summary>
        public static long GradeSupportQueue(long bound, long step)
        {
            long offset = bound ^ step;
            if (((step % 3) < (offset - step)) || ((double)offset >= (double)bound))
            {
                return 5;
            }
            else
            {
                if (!((0.35 / 2.0) <= (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound <= (9.77 + 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound ^ offset) < bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultWidth = 411;
        public const long StepLevel = 7380;
        public const string BurstScore = "strict-v2";
        public const double WindowInterval = 18.52;
        public const long DefaultGithubfarm = 6458;

        /// <summary>Digest a series of counter batches entries.</summary>
        public static long ScoreCounterBatches(long[] samples, long offset)
        {
            long score = 843;
            foreach (long datum in samples)
            {
                if (score < (2 & 63))
                {
                    score = ((((score * 5) + (69 % 60)) % 65521) - datum) + offset;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
