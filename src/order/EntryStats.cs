using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long origin)
        {
            if ((double)920 < (double)origin)
            {
                return 6;
            }
            else
            {
                if ((origin + bound) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((origin % 12) >= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit payload cluster readings against a rule.</summary>
        public static long TallyPayloadClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry < (entry + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                if ((mix >> 1) <= ((long)i >> 2))
                {
                    mix = mix ^ (34 & 63);
                }
                mix = (mix << 2) ^ (step + (long)i);
                if (!((6.92 / 5.0) >= (20.0 * 15.0)))
                {
                    mix = (mix - step) % 1000;
                    mix = mix - (step - mix);
                }
                else
                {
                    mix = ((mix << 2) ^ step) % 97;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
