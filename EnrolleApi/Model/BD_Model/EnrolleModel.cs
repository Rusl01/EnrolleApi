﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnrolleApi.Model.BD_Model
{
    [Table("ListEnrollee2", Schema = "dbo")]
    [Keyless]
    public class EnrolleModel
    {
        [NotMapped]
        public int? key { get; set; }

        [Column("Уникальный код")]
        public string? Snils { get; set; }

        [Column("Тип вступительных испытаний (по заявлениям)")]
        public string? TypeIsp { get; set; }

        [Column("Сумма баллов")]
        public int? SumBal_ID { get; set; }

        [Column("Сумма баллов по предметам")]
        public int? SumBal { get; set; }
        
        [Column("Предмет1")]
        public int? Pred_1 { get; set; }
        [Column("Предмет2")]
        public int? Pred_2 { get; set; }

        [Column("Предмет3")]
        public int? Pred_3 { get; set; }

        [Column("Предмет4")]
        public int? Pred_4 { get; set; }
        [Column("Сумма баллов за инд.дост")]
        public int? SumBal_OnlyID { get; set; }

        [Column("Приоритет")]
        public int? Priority { get; set; }       
        
        [Column("Нуждаемость в общежитии")]
        public string? NeedRoom { get; set; }

        [Column("Особенности приема")]
        public string? ReceptionFeatures { get; set; }
        
        [Column("Основание поступления")]
        public string? ReasonForAdmission { get; set; }        
        
        [Column("Категория приема")]
        public string? AdmissionCategory { get; set; } 
        
        [Column("Форма обучения")]
        public string? FormStudy { get; set; }

        
        
        [Column("НаправлениеИспециальность")]
        public string? Napravlenie { get; set; }       
        
        [Column("Профиль")]
        public string? Profil { get; set; }

        [Column("Оригинал")]
        public string? OriginalDiplom { get; set; }




    }
}
