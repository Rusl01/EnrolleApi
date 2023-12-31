﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace EnrolleApi.Model.BD_Model
{
    [Table("ListEnrollee2", Schema = "dbo")]
    [Keyless]
    public class EnrolleeModel2
    {
        [Column("СуммаБаллов")]
        public int? SumBall { get; set; }

        [Column("ФизическоеЛицо")]
        public string? FIO { get; set; }

        [Column("ФормаОбучения")]
        public string? FormStudy { get; set; }

        [Column("Направление")]
        public string Napravlenie { get; set; }

        [Column("УровеньПодготовки")]
        public string? LevelTraining { get; set; }

        [Column("ОснованиеПоступления")]
        public string? FoundationReceipts { get; set; }

        [Column("КатегорияПриема")]
        public string? AdmissionCategory { get; set; }

        [Column("КонкурснаяГруппа")]
        public string? Naprav_Group { get; set; }


        [Column("Профиль")]
        public string? Profil { get; set; }

        [Column("Приоритет")]
        public int? Prioritet { get; set; }

        [Column("ТипИспытаний")]
        public string? TypeIsp { get; set; }

        [Column("ЕстьОригиналВВузе")]
        public string? HaveDiplomInVus { get; set; }


        [Column("НомерЛД")]
        public int? IdEnrolle { get; set; }

        [Column("СНИЛС")]
        public string? Snils { get; set; }

        [Column("Факультет")]
        public string? Institut { get; set; }

        [Column("Сумма с ИД")]
        public int? SumBall_ID { get; set; }

        [Column("Согласие")]
        public string? Soglasie { get; set; }
    }


}
