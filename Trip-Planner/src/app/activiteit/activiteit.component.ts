import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Activiteit } from '../classes/Activiteit';
import { ActivityService } from '../activiteit.service';

@Component({
  selector: 'app-activiteit',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './activiteit.component.html',
  styleUrls: ['./activiteit.component.css']
})

export class ActiviteitComponent implements OnInit {
  activities: Activiteit[] = [];

  constructor(private activityService: ActivityService) {}

  ngOnInit() {
    this.loadActivities();
  }

  loadActivities() {
    this.activityService.getActivities().subscribe(
      (activities) => {
        this.activities = activities;
      },
      (error) => {
        console.error('Error loading activities:', error);
      }
    );
  }
}