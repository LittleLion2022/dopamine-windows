﻿using System;

namespace Dopamine.Common.Services.Metadata
{
    public class MetadataChangedEventArgs : EventArgs
    {
        #region Properties
        public bool IsArtistChanged { get; set; }
        public bool IsGenreChanged { get; set; }
        public bool IsAlbumChanged { get; set; }
        public bool IsTrackChanged { get; set; }

        public bool IsMetadataChanged
        {
            get { return this.IsArtistChanged | this.IsGenreChanged | this.IsAlbumChanged | this.IsTrackChanged; }
        }
        #endregion

        #region Construction
        public MetadataChangedEventArgs()
        {
            this.IsArtistChanged = false;
            this.IsGenreChanged = false;
            this.IsAlbumChanged = false;
            this.IsTrackChanged = false;
        }
        #endregion
    }

}
