﻿using System;
using System.ComponentModel.DataAnnotations;
using ApiBackEnd.Models;
using ApiMultiPartFormData.Models;

namespace ApiBackEnd.ViewModels
{
    public class BasicUploadViewModel
    {
        #region Properties

        public Guid Id { get; set; }

        public Guid? AttachmentId { get; set; }

        /// <summary>
        /// Author information.
        /// </summary>
        [Required]
        public User Author { get; set; }

        /// <summary>
        /// Attachment.
        /// </summary>
        [Required]
        public HttpFile Attachment { get; set; }

        #endregion
    }
}