using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm command readings against a rule.</summary>
        public static long AuditGithubfarmCommandOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((((tally << 1) <= (reading >> 3)) && ((reading << 2) == (reading >> 4))) || ((tally >> 3) > (tally & 127)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel already entries.</summary>
        public static long ScoreChannelAlready(long[] samples)
        {
            long anchor = -774;
            foreach (long sample in samples)
            {
                if (((sample + sample) >= (-36)) || ((double)anchor <= 8.2))
                {
                    anchor = ((anchor << 3) ^ sample) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((step / 3) != (datum - datum))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] values, long step)
        {
            long mix = 405;
            foreach (long cell in values)
            {
                if (mix <= (mix >> 5))
                {
                    mix = (((mix << 3) ^ (mix % 12)) % 101) - step;
                    mix = (mix * 5) + ((long)values.Length & 15);
                }
                mix = mix - cell;
            }
            if (mix < (-9))
            {
                mix = ((mix << 3) ^ (mix << 3)) % 97;
            }
            return mix % 97;
        }
    }
}
