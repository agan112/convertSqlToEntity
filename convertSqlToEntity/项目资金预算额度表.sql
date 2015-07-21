-- Create table
create table GFM_PS_PFS_BALANCE
(
  balance_id             NUMBER not null,
  balance_type_id        NUMBER not null,
  budget_amount          NUMBER(16,2) default 0,
  budget_add_amount      NUMBER(16,2) default 0,
  budget_add_amounting   NUMBER(16,2) default 0,
  budget_sub_amount      NUMBER(16,2) default 0,
  budget_sub_amounting   NUMBER(16,2) default 0,
  assign_add_amount      NUMBER(16,2) default 0,
  assign_add_amounting   NUMBER(16,2) default 0,
  assign_sub_amount      NUMBER(16,2) default 0,
  assign_sub_amounting   NUMBER(16,2) default 0,
  modulate_add_amount    NUMBER(16,2) default 0,
  modulate_add_amounting NUMBER(16,2) default 0,
  modulate_sub_amount    NUMBER(16,2) default 0,
  modulate_sub_amounting NUMBER(16,2) default 0,
  quota_amount           NUMBER(16,2) default 0,
  quota_back_amount      NUMBER(16,2) default 0,
  stock_plan_amount      NUMBER(16,2) default 0,
  ps_pfs_id              NUMBER,
  prj_code               VARCHAR2(42) not null,
  year                   NUMBER(4),
  stock_flag             NUMBER(1),
  pfs_detail_content     VARCHAR2(200),
  prj_budget_type_id     NUMBER,
  prj_budget_kind_id     NUMBER,
  bgt_source_id          NUMBER,
  exp_func_id            NUMBER,
  exp_eco_id             NUMBER,
  quota_level_id         NUMBER,
  agency_id              NUMBER,
  in_mof_dep_id          NUMBER,
  mof_dep_id             NUMBER,
  in_ps_agency_id        NUMBER,
  surplus_flag           NUMBER(1),
  puritem_id             NUMBER,
  rcid                   NUMBER,
  prj_std_id             NUMBER(20),
  pay_flag               NUMBER(1),
  is_assign              NUMBER,
  last_ver               NUMBER,
  create_date            DATE,
  create_user            NUMBER,
  ele_hold1_id           NUMBER,
  ele_hold2_id           NUMBER,
  ele_hold3_id           NUMBER,
  ele_hold4_id           NUMBER,
  ele_hold5_id           NUMBER,
  ele_hold6_id           NUMBER,
  ele_hold7_id           NUMBER,
  ele_hold8_id           NUMBER,
  ele_hold9_id           NUMBER,
  ele_hold10_id          NUMBER,
  n_field5               NUMBER,
  n_field4               NUMBER,
  n_field3               NUMBER,
  n_field2               NUMBER,
  n_field1               NUMBER,
  c_field5               VARCHAR2(50),
  c_field4               VARCHAR2(50),
  c_field3               VARCHAR2(50),
  c_field2               VARCHAR2(50),
  c_field1               VARCHAR2(50),
  ele_str                VARCHAR2(60),
  inv_pay_amount         NUMBER,
  financing_type_id      NUMBER,
  pay_amount             NUMBER(16,2) default 0
);

-- Add comments to the table 
comment on table GFM_PS_PFS_BALANCE
  is '项目资金预算额度表';
-- Add comments to the columns 
comment on column GFM_PS_PFS_BALANCE.balance_id
  is '额度ID主键';
comment on column GFM_PS_PFS_BALANCE.balance_type_id
  is '额度类型ID';
comment on column GFM_PS_PFS_BALANCE.budget_amount
  is '年初预算金额';
comment on column GFM_PS_PFS_BALANCE.budget_add_amount
  is '财力加存储列，（已生效）';
comment on column GFM_PS_PFS_BALANCE.budget_add_amounting
  is '财力在途追加存储列';
comment on column GFM_PS_PFS_BALANCE.budget_sub_amount
  is '财力收回存储列，已生效';
comment on column GFM_PS_PFS_BALANCE.budget_sub_amounting
  is '财力在途收回存储列';
comment on column GFM_PS_PFS_BALANCE.assign_add_amount
  is '分配调入生效金额';
comment on column GFM_PS_PFS_BALANCE.assign_add_amounting
  is '分配在途调入';
comment on column GFM_PS_PFS_BALANCE.assign_sub_amount
  is '分配调出生效金额';
comment on column GFM_PS_PFS_BALANCE.assign_sub_amounting
  is '分配调出在途金额';
comment on column GFM_PS_PFS_BALANCE.modulate_add_amount
  is '调剂入生效金额';
comment on column GFM_PS_PFS_BALANCE.modulate_add_amounting
  is '调剂入在途金额';
comment on column GFM_PS_PFS_BALANCE.modulate_sub_amount
  is '调剂出金额生效金额';
comment on column GFM_PS_PFS_BALANCE.modulate_sub_amounting
  is '调剂出金额在途金额';
comment on column GFM_PS_PFS_BALANCE.quota_amount
  is '转指标金额';
comment on column GFM_PS_PFS_BALANCE.quota_back_amount
  is '转指标收回金额';
comment on column GFM_PS_PFS_BALANCE.stock_plan_amount
  is '政府采购计划金额';
comment on column GFM_PS_PFS_BALANCE.ps_pfs_id
  is '资金ID主键';
comment on column GFM_PS_PFS_BALANCE.prj_code
  is '项目编码';
comment on column GFM_PS_PFS_BALANCE.year
  is '预算年度';
comment on column GFM_PS_PFS_BALANCE.stock_flag
  is '1政府采购，0非政府采购';
comment on column GFM_PS_PFS_BALANCE.prj_budget_type_id
  is '预算类型id';
comment on column GFM_PS_PFS_BALANCE.prj_budget_kind_id
  is '预算性质id';
comment on column GFM_PS_PFS_BALANCE.bgt_source_id
  is '指标来源id';
comment on column GFM_PS_PFS_BALANCE.exp_func_id
  is '功能科目ID';
comment on column GFM_PS_PFS_BALANCE.exp_eco_id
  is '经济科目ID';
comment on column GFM_PS_PFS_BALANCE.quota_level_id
  is '转指标级次ID';
comment on column GFM_PS_PFS_BALANCE.agency_id
  is '申报单位id';
comment on column GFM_PS_PFS_BALANCE.in_mof_dep_id
  is '项目主管科室';
comment on column GFM_PS_PFS_BALANCE.mof_dep_id
  is '业务处室id';
comment on column GFM_PS_PFS_BALANCE.in_ps_agency_id
  is '执行单位id';
comment on column GFM_PS_PFS_BALANCE.surplus_flag
  is '是否预留';
comment on column GFM_PS_PFS_BALANCE.puritem_id
  is '采购品目';
comment on column GFM_PS_PFS_BALANCE.rcid
  is '权限';
comment on column GFM_PS_PFS_BALANCE.prj_std_id
  is '标准项目ID';
comment on column GFM_PS_PFS_BALANCE.pay_flag
  is '是否转移支付补助下级';
comment on column GFM_PS_PFS_BALANCE.is_assign
  is '是否 待分项目  0 否  1 是， 否为可执行指标';
comment on column GFM_PS_PFS_BALANCE.last_ver
  is '版本号';
comment on column GFM_PS_PFS_BALANCE.create_date
  is '创建时间';
comment on column GFM_PS_PFS_BALANCE.create_user
  is '创建用户';
comment on column GFM_PS_PFS_BALANCE.ele_str
  is '额度汇总串，用于标识唯一一条额度';
comment on column GFM_PS_PFS_BALANCE.inv_pay_amount
  is '政府投资安排资金金额';
comment on column GFM_PS_PFS_BALANCE.financing_type_id
  is '筹资类型';
comment on column GFM_PS_PFS_BALANCE.pay_amount
  is '支付金额';
-- Create/Recreate primary, unique and foreign key constraints 
alter table GFM_PS_PFS_BALANCE
  add constraint PK_GFM_PS_PFS_BALANCE primary key (BALANCE_ID);
  commit;